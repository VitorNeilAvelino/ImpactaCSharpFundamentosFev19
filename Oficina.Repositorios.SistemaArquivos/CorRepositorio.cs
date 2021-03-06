﻿using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio : ICorRepositorio
    {
        private string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"];

        public void Atualizar(Cor cor)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Cor cor)
        {
            throw new NotImplementedException();
        }

        //ToDo: OO - polimorfismo por sobrecarga
        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var cor = new Cor();
                cor.Id = Convert.ToInt32(linha.Substring(0, 5));
                cor.Nome = linha.Substring(5);

                cores.Add(cor);
            }

            return cores;
        }

        public Cor Selecionar(int id)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var linhaId = Convert.ToInt32(linha.Substring(0, 5));

                if (id == linhaId)
                {
                    cor = new Cor();
                    cor.Id = id;
                    cor.Nome = linha.Substring(5);

                    break;
                }
            }

            return cor;
        }
    }
}
