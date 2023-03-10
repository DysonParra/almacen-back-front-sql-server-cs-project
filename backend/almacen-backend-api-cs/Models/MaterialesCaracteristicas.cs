/*
 * @fileoverview    {MaterialesCaracteristicas} se encarga de realizar tareas específicas.
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementación realizada.
 * @version 2.0     Documentación agregada.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Definición de {@code MaterialesCaracteristicas}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class MaterialesCaracteristicas {

        [Key]
        public Int64? IntIdMaterialCaracteristica { get; set; }
        public String? StrValorCaracteristica { get; set; }
        public String? StrUsuario { get; set; }
        public DateTime? DtFecha { get; set; }
        public String? StrCodigoMaterial { get; set; }
        public Int64? IntIdMaterial { get; set; }
        public Int64? IntIdTipoMaterialCaracteristica { get; set; }
        public Int64? IntIdTipoMaterial { get; set; }

    }

}