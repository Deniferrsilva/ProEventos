using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProEventos.API.Models
{
    [Keyless] 
    [Table("GBH150")]
    public class Paciente
    {
        
        [Column("R_E_C_N_O_")]
        public int RecnoPaciente { get; set; }
        [Column("GBH_CODPAC")]
        public string CodPaciente { get; set; }
        
        [Column("GBH_NOME")]
        public string NomePaciente { get; set; }
       
        [Column("GBH_DTNASC")]
        public string DtNascimento { get; set; }
        [Column("GBH_SEXO")]
        public string SexoPaciente { get; set; } 
    }
}