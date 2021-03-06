using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LancheMVC_Aplication.DTOs
{
    public class AllDTo
    {
        public CategoriaDTo categoriadto { get; set; }
        public LancheDTO   LancheDTO { get; set; }

        public ResultCategoria resultCategoria { get; set; }
        public ResultLanche resultLanche { get; set; }

        public class ResultCategoria
        {
            public List<CategoriaDTo> lCategorias { get; set; }
        }

        public class ResultLanche
        {
            public List<LancheDTO> lLanches { get; set; }
        }

    }
}
