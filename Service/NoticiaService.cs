using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XNews.Domain;
using XNews.Repository;

namespace XNews.Service
{
    public class NoticiaService
    {
        private NoticiaRepository _noticiaRepository = new NoticiaRepository();
        public List<Noticia> Listar()
        {
            return _noticiaRepository.Listar();
        }
    }
}
