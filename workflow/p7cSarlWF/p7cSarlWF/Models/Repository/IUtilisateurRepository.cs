﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p7cSarlWF.Models.Repository
{
    interface IUtilisateurRepository
    {
        List<Utilisateur> GetListeAllUtilisateur();

        List<Client> GetListeAllClient();

        Client saveClient(Client client);
    }
}
