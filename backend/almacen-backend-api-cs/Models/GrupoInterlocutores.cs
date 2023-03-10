/*
 * @fileoverview    {GrupoInterlocutores} se encarga de realizar tareas específicas.
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
 * TODO: Definición de {@code GrupoInterlocutores}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class GrupoInterlocutores {

        [Key]
        public Int64? IntIdGrupoInterlocutor { get; set; }
        public String? StrNombreGrupo { get; set; }
        public String? StrDescripcion { get; set; }
        public String? StrCuentaContable { get; set; }
        public String? StrUsuario { get; set; }
        public DateTime? DtFecha { get; set; }
        public Int64? IntIdListaPrecio { get; set; }

    }

}