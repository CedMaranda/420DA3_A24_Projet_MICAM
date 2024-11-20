using System;
using System.Collections.Generic;

namespace _420DA3_A24_Projet.Business.Domain {
    /// <summary>
    /// Classe représentant un entrepôt dans l'application.
    /// </summary>
    public class Warehouse {
        /// <summary>
        /// Longueur maximale du nom de l'entrepôt.
        /// </summary>
        public const int NameMaxLength = 128;

        /// <summary>
        /// Identifiant unique de l'entrepôt.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'entrepôt.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Identifiant de l'adresse associée à l'entrepôt.
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Date de création de l'entrepôt.
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Date de dernière modification.
        /// </summary>
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Date de suppression de l'entrepôt.
        /// </summary>
        public DateTime? DateDeleted { get; set; }

        /// <summary>
        /// Numéro de version pour la gestion de la concurrence.
        /// </summary>
        public byte[] RowVersion { get; set; } = null!;

        /// <summary>
        /// Adresse associée à l'entrepôt.
        /// </summary>
        public virtual Adresse Address { get; set; } = null!;

        /// <summary>
        /// Liste des employés assignés à cet entrepôt.
        /// </summary>
        public virtual List<User> Employees { get; set; } = new List<User>();

        /// <summary>
        /// Liste des produits stockés dans cet entrepôt.
        /// </summary>
        public virtual List<Product> Products { get; set; } = new List<Product>();

        /// <summary>
        /// Constructeur pour créer un entrepôt.
        /// </summary>
        /// <param name="name">Le nom de l'entrepôt.</param>
        /// <param name="addressId">L'identifiant de l'adresse associée.</param>
        public Warehouse(string name, int addressId) {
            if (!ValidateName(name))
                throw new ArgumentOutOfRangeException("Name", $"Name length must not exceed {NameMaxLength} characters.");

            Name = name;
            AddressId = addressId;
            DateCreated = DateTime.Now;
        }

        /// <summary>
        /// Méthode de validation du nom de l'entrepôt.
        /// </summary>
        /// <param name="name">Nom à valider.</param>
        /// <returns>Vrai si le nom est valide, sinon faux.</returns>
        public static bool ValidateName(string name) {
            return !string.IsNullOrEmpty(name) && name.Length <= NameMaxLength;
        }

        /// <summary>
        /// Surcharge de la méthode ToString().
        /// </summary>
        /// <returns>Une chaîne de caractères décrivant l'entrepôt.</returns>
        public override string ToString() {
            return $"#{Id} - {Name}";
        }
    }
}