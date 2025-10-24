using System;
using System.Security.Cryptography;
using System.Text;

namespace POS
{
    /// <summary>
    /// Helper class for secure password hashing and verification using PBKDF2
    /// </summary>
    public static class PasswordHelper
    {
        // Configuration constants
        private const int SaltSize = 16; // 128 bits
        private const int HashSize = 20; // 160 bits
        private const int Iterations = 10000; // PBKDF2 iterations

        /// <summary>
        /// Creates a hash from a password
        /// </summary>
        /// <param name="password">The password to hash</param>
        /// <returns>The hashed password in format: iterations.salt.hash</returns>
        public static string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            // Hash the password with PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            // Combine salt and hash
            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert to base64 for storage
            string base64Hash = Convert.ToBase64String(hashBytes);

            // Format: iterations.salt+hash
            return $"{Iterations}.{base64Hash}";
        }

        /// <summary>
        /// Verifies a password against a hash
        /// </summary>
        /// <param name="password">The password to verify</param>
        /// <param name="hashedPassword">The hash to verify against (format: iterations.salt.hash)</param>
        /// <returns>True if password matches, false otherwise</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            try
            {
                // Extract iteration and base64 string
                var parts = hashedPassword.Split('.');
                if (parts.Length != 2)
                {
                    // If it's not in the new format, it might be plain text (legacy)
                    // For backward compatibility during migration
                    return false;
                }

                var iterations = int.Parse(parts[0]);
                var base64Hash = parts[1];

                // Get hash bytes
                var hashBytes = Convert.FromBase64String(base64Hash);

                // Get salt
                var salt = new byte[SaltSize];
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);

                // Compute hash of input password
                var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // Compare the results
                for (int i = 0; i < HashSize; i++)
                {
                    if (hashBytes[i + SaltSize] != hash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a password is in the old plain text format
        /// </summary>
        /// <param name="storedPassword">The stored password from database</param>
        /// <returns>True if it's plain text (needs hashing), false if already hashed</returns>
        public static bool IsPlainText(string storedPassword)
        {
            // Hashed passwords are in format: iterations.base64hash
            // Plain text passwords won't have this format
            if (string.IsNullOrEmpty(storedPassword))
                return false;

            var parts = storedPassword.Split('.');
            if (parts.Length != 2)
                return true; // Plain text

            // Try to parse iterations
            if (!int.TryParse(parts[0], out int iterations))
                return true; // Plain text

            // Try to parse base64
            try
            {
                Convert.FromBase64String(parts[1]);
                return false; // Hashed
            }
            catch
            {
                return true; // Plain text
            }
        }

        /// <summary>
        /// Validates password strength
        /// </summary>
        /// <param name="password">The password to validate</param>
        /// <returns>True if password meets minimum requirements</returns>
        public static bool ValidatePasswordStrength(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            // Minimum 6 characters for this POS system
            // You can add more requirements (uppercase, numbers, special chars) as needed
            return password.Length >= 6;
        }

        /// <summary>
        /// Gets password strength message for user feedback
        /// </summary>
        public static string GetPasswordStrengthMessage(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return "Password cannot be empty";

            if (password.Length < 6)
                return "Password must be at least 6 characters long";

            // Optional: Add more strength indicators
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else hasSpecial = true;
            }

            int strength = 0;
            if (hasUpper) strength++;
            if (hasLower) strength++;
            if (hasDigit) strength++;
            if (hasSpecial) strength++;

            if (strength >= 3)
                return "Strong password";
            else if (strength >= 2)
                return "Medium password";
            else
                return "Weak password - consider adding numbers or symbols";
        }
    }
}
