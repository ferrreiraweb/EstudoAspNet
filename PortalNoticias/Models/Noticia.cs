using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PortalNoticias.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }

        [DisplayFormat(DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> getTodasAsNoticias()
        {
            var TodasAsNoticias = new List<Noticia>()
            {
                new Noticia(){
                    NoticiaId = 1,
                    Titulo = "Edicao de hoje de Charlie Hebdo",
                    Conteudo = "A edição de hoje do semanário satírico frances Charlie Hebdo tem 3 milhões de exemplares e sai em mais de 20 países, com versões em cinco línguas, incluindo o árabe e o turco. Esta edição será traduzida em inglês, espanhol e árabe na versão digital e ...",
                    Categoria = "Internacional",
                    Data = new DateTime(2014, 12, 29)
                },
                new Noticia()
                {
                    NoticiaId = 2,
                    Titulo = "Levy diz que ajuste econômico não é 'saco de maldades'",
                    Conteudo = "Rio - O ministro da Fazenda, Joaquim Levy, reafirmou ontem que haverá ajustes em impostos, mas descartou um “saco de maldades ou pacotes” para fazer correções na economia e nas contas do governo. Em encontro com jornalistas e acompanhado do ...",
                    Categoria = "Economia",
                    Data = new DateTime(2015, 1, 5)
                },
                new Noticia()
                {
                    NoticiaId = 3,
                    Titulo = "Smartphones da Motorola devem receber Android Lollipop em breve",
                    Conteudo = "Smartphones de 2013 e 2014 da Motorola vão começar a receber a atualização do Android Lollipop em breve. A informação é de Luciano Carvalho, engenheiro de software da empresa, em uma postagem no Google+. Olhar Digital. Smartphones de 2013 e ...",
                    Categoria = "Economia",
                    Data = new DateTime(2015, 01, 11)
                },
                new Noticia()
                {
                    NoticiaId = 4,
                    Titulo = "Dez pessoas mortas num ônibus atingido por bomba na Ucrânia",
                    Conteudo = "Uma bomba atingiu nesta terça-feira um ônibus na província de Donetsk, na Ucrânia, mantando pelo menos 10 pessoas e ferindo outras 13. O incidente, que ocorreu por volta das 14h30, foi confirmado pelo governo local, que suspendeu todas as linhas de ...",
                    Categoria = "Internacional",
                    Data = new DateTime(2015, 01, 10)
                },
                new Noticia()
                {
                    NoticiaId = 5,
                    Titulo = "Em três anos, processos contra o SUS aumentam mais de 30%",
                    Conteudo = "O número de pacientes que recorreram à Justiça contra o SUS para conseguir tratamento ou remédios subiu 32%. A informação é do jornal Estado de S. Paulo, que obteve dados do Tribunal de Justiça de São Paulo. Em 2010, foram 1514 ações nas varas",
                    Categoria = "Saúde",
                    Data = new DateTime(2015, 01, 11)
                },
                new Noticia()
                {
                    NoticiaId = 6,
                    Titulo = "Estudo indica que a epidemia de ébola pode ser contida até junho",
                    Conteudo = "Um estudo norte-americano divulgado, esta terça-feira, pela revista PLOS Biology indica que a epidemia do ébola poderá ser contida dentro de cinco meses na Libéria, caso se mantenha a percentagem de 85% de hospitalizações. Nas últimas semanas, a",
                    Categoria = "Saúde",
                    Data = new DateTime(2015, 01, 09)

                },
                new Noticia()
                {
                    NoticiaId = 7,
                    Titulo = "MEC divulga as notas do Enem 2014",
                    Conteudo = "O Ministério da Educação liberou na noite desta terça-feira (13) a consulta individual das notas do Exame Nacional do Ensino Médio (Enem) ...",
                    Categoria = "Educação",
                    Data =new DateTime(2015, 01, 05)
                }
            };

            return TodasAsNoticias;



        }



    }
}