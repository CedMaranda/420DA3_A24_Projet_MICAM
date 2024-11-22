using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business;
internal class WsysApplication {

    private WsysDbContext context;
    public AdresseService AdresseService { get; private set; }
    public ClientService ClientService { get; private set; }




    public WsysApplication() {

        this.context = new WsysDbContext();
        this.AdresseService = new AdresseService();
        this.ClientService = new ClientService();



    }






}


