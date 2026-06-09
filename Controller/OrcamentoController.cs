using Projeto_DA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Controller
{
    internal class OrcamentoController
    {
        public static Orcamento GetDoMes(int mes, int ano)
        {
            using (var db = new AppDbContext())
                return db.Orcamentos.FirstOrDefault(o => o.Mes == mes && o.Ano == ano);
        }

        public static void Guardar(Orcamento o)
        {
            using (var db = new AppDbContext())
            {
                if (o.Id == 0)
                    db.Orcamentos.Add(o);
                else
                {
                    var existente = db.Orcamentos.Find(o.Id);
                    existente.Mes = o.Mes;
                    existente.Ano = o.Ano;
                    existente.ValorMaximo = o.ValorMaximo;
                    existente.UtilizadorAlteracaoId = o.UtilizadorAlteracaoId;
                    existente.DataAlteracao = o.DataAlteracao;
                }
                db.SaveChanges();

            }
        }
    }
}