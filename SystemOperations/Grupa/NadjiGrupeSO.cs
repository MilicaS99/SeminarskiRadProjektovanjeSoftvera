﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class NadjiGrupeSO : SystemOperationBase
    {
        public string kriterijum { get; set; }
        public List<Pohadjanje> Rezultat { get; set; }
        public NadjiGrupeSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }
        protected override void Execute()
        {
            //Rezultat = broker.NadjiGrupe(kriterijum);
            Rezultat = repository.Pronadji(new Pohadjanje(), kriterijum).OfType<Pohadjanje>().ToList();
        }
    }
}
