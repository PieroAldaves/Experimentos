
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MetroWeb.Models
{

using System;
    using System.Collections.Generic;
    
public partial class tb_Orga_Area
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tb_Orga_Area()
    {

        this.tb_Plan_Problema = new HashSet<tb_Plan_Problema>();

        this.tb_Indi_Indicador = new HashSet<tb_Indi_Indicador>();

    }


    public int Id_Area { get; set; }

    public string Descripcion_Area { get; set; }

    public string Codigo { get; set; }

    public string Abreviatura { get; set; }

    public Nullable<int> Id_Estado { get; set; }

    public string Usuario_Creacion { get; set; }

    public Nullable<System.DateTime> Fecha_Creacion { get; set; }

    public string Usuario_Modificacion { get; set; }

    public Nullable<System.DateTime> Fecha_Modificacion { get; set; }

    public string Flag_Eliminado { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tb_Plan_Problema> tb_Plan_Problema { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tb_Indi_Indicador> tb_Indi_Indicador { get; set; }

}

}
