//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace W3_2018_2C_TP
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvitacionPedidoGustoEmpanadaUsuario
    {
        public int IdInvitacionPedidoGustoEmpanadaUsuario { get; set; }
        public int IdPedido { get; set; }
        public int IdGustoEmpanada { get; set; }
        public int IdUsuario { get; set; }
        public int Cantidad { get; set; }
    
        public virtual GustoEmpanada GustoEmpanada { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
