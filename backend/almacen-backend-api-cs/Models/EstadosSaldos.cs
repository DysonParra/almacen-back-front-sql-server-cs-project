/*
 * @fileoverview    {EstadosSaldos}
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementation done.
 * @version 2.0     Documentation added.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Description of {@code EstadosSaldos}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class EstadosSaldos {

        [Key]
        public Int64? IntIdEstadoSaldo { get; set; }
        public String? StrDescripcionEstadoSaldo { get; set; }
        public String? StrCodigoColor { get; set; }
        public Boolean? BitEstaEnReposicion { get; set; }
        public String? StrUsuario { get; set; }
        public DateTime? DtFecha { get; set; }

    }

}