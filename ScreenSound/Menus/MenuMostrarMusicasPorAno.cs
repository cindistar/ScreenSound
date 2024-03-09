﻿using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
    internal class MenuMostrarMusicasPorAno : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Mostrar musicas por ano de lançamento");
            Console.Write("Digite o ano para consultar músicas:");
            string anoLancamento = Console.ReadLine()!;
            var musicaDal = new DAL<Musica>(new ScreenSoundContext());
            var anoLancamentoRecuperado = musicaDal.RecuperarPor(a => a.AnoLancamento == Convert.ToInt32(anoLancamento));

            if (anoLancamentoRecuperado is not null)
            {
                Console.WriteLine($"\nMusicas do Ano {anoLancamento}:");
                anoLancamentoRecuperado.ExibirFichaTecnica();
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO ano {anoLancamento} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}