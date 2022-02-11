using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Compte_gRPC.Models
{
    public class Compte
    {
        public int IdCompte { get; set; }
        public string IBAN { get; set; }
        public float Money { get; set; }
        public DateTime validity { get; set; }
        public bool IsValid { get; set; }
        public User User { get; set; }
        public int UserFk { get; set; }
        public Compte(){}
        public Compte(DateTime exp)
        {
            this.validity = exp;
        }
    }
}
