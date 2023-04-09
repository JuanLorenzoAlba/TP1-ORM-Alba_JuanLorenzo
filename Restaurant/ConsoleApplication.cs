using Application.UseCase.TipoMercaderias;
using Domain.Entities;
using Infrastructure.Command;
using Infrastructure.Config;
using Infrastructure.Persistence;
using Infrastructure.Querys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class ConsoleApplication
    {
        static void Main(string[] args)
        {
            //var ctx = new RestaurantContext();

            //var tipoMercaderia = new TipoMercaderia { Descripcion = "Mortal Kombat" };

            //var tipoMercaderiaCommand = new TipoMercaderiaCommand(ctx);
            //var tipoMercaderiaQuery = new TipoMercaderiaQuery(ctx);

            //var tipoMercaderiaService = new TipoMercaderiaService(tipoMercaderiaCommand, tipoMercaderiaQuery);

            //tipoMercaderiaService.CreateTipoMercaderia("Mortal Kombat");
            //tipoMercaderiaService.CreateTipoMercaderia("Need for Speed");
            //tipoMercaderiaService.CreateTipoMercaderia("Lol");
            //tipoMercaderiaService.CreateTipoMercaderia("Rocket League");

            //tipoMercaderiaService.RemoveTipoMercaderia(1);
        }
    }
}