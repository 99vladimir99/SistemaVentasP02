
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SistemaVentasP2.MODEL
{

using System;
    using System.Collections.Generic;
    
public partial class tb_producto
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tb_producto()
    {

        this.tb_detalleVenta = new HashSet<tb_detalleVenta>();

    }


    public int idProducto { get; set; }

    public string nombreProducto { get; set; }

    public string precioProducto { get; set; }

    public string estadoProducto { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tb_detalleVenta> tb_detalleVenta { get; set; }

}

}
