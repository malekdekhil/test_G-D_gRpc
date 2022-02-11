using Compte_gRPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compte_gRPC.Interfaces
{
    public interface ICompte
    {
        int GetIDCompte();
        string GetIban();
        float GetMoney();
        DateTime GetDateCrea();
        bool GetValidDate();
        User GetUser();
        Task<List<Compte>> GetAllCompte();
        string GetRandomErreur(List<Compte> compte);
     }
}
