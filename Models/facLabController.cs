﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraerLIVERDED.Models
{
    public class facLabController
    {
        // GET: FacCp
        public ModelFact modelFact = new ModelFact();

        
        public void getMercancias(string Ai_orden, string Av_cmd_code, string Av_cmd_description, string Af_weight, string Av_weightunit, string Af_count, string Av_countunit)
        {
             this.modelFact.getMercancias(Ai_orden, Av_cmd_code, Av_cmd_description, Af_weight, Av_weightunit, Af_count, Av_countunit);
        }
        
    }
}
