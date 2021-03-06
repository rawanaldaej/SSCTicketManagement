//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SSC_Ticket_Management.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SSC_TicketEntities : DbContext
    {
        public SSC_TicketEntities()
            : base("name=SSC_TicketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
    
        public virtual ObjectResult<Ticket_CRUD_Result> Ticket_CRUD(string action, Nullable<int> ticket_ID, string ticket_Title, string ticket_Description, string ticket_Status, string cREATED_BY, Nullable<int> ticket_Admin)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var ticket_IDParameter = ticket_ID.HasValue ?
                new ObjectParameter("Ticket_ID", ticket_ID) :
                new ObjectParameter("Ticket_ID", typeof(int));
    
            var ticket_TitleParameter = ticket_Title != null ?
                new ObjectParameter("Ticket_Title", ticket_Title) :
                new ObjectParameter("Ticket_Title", typeof(string));
    
            var ticket_DescriptionParameter = ticket_Description != null ?
                new ObjectParameter("Ticket_Description", ticket_Description) :
                new ObjectParameter("Ticket_Description", typeof(string));
    
            var ticket_StatusParameter = ticket_Status != null ?
                new ObjectParameter("Ticket_Status", ticket_Status) :
                new ObjectParameter("Ticket_Status", typeof(string));
    
            var cREATED_BYParameter = cREATED_BY != null ?
                new ObjectParameter("CREATED_BY", cREATED_BY) :
                new ObjectParameter("CREATED_BY", typeof(string));
    
            var ticket_AdminParameter = ticket_Admin.HasValue ?
                new ObjectParameter("Ticket_Admin", ticket_Admin) :
                new ObjectParameter("Ticket_Admin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ticket_CRUD_Result>("Ticket_CRUD", actionParameter, ticket_IDParameter, ticket_TitleParameter, ticket_DescriptionParameter, ticket_StatusParameter, cREATED_BYParameter, ticket_AdminParameter);
        }
    
        public virtual ObjectResult<Ticket> Ticket_PerformCRUD(string action, Nullable<int> ticket_ID, string ticket_Title, string ticket_Description, string ticket_Status, string cREATED_BY, Nullable<int> ticket_Admin)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var ticket_IDParameter = ticket_ID.HasValue ?
                new ObjectParameter("Ticket_ID", ticket_ID) :
                new ObjectParameter("Ticket_ID", typeof(int));
    
            var ticket_TitleParameter = ticket_Title != null ?
                new ObjectParameter("Ticket_Title", ticket_Title) :
                new ObjectParameter("Ticket_Title", typeof(string));
    
            var ticket_DescriptionParameter = ticket_Description != null ?
                new ObjectParameter("Ticket_Description", ticket_Description) :
                new ObjectParameter("Ticket_Description", typeof(string));
    
            var ticket_StatusParameter = ticket_Status != null ?
                new ObjectParameter("Ticket_Status", ticket_Status) :
                new ObjectParameter("Ticket_Status", typeof(string));
    
            var cREATED_BYParameter = cREATED_BY != null ?
                new ObjectParameter("CREATED_BY", cREATED_BY) :
                new ObjectParameter("CREATED_BY", typeof(string));
    
            var ticket_AdminParameter = ticket_Admin.HasValue ?
                new ObjectParameter("Ticket_Admin", ticket_Admin) :
                new ObjectParameter("Ticket_Admin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ticket>("Ticket_PerformCRUD", actionParameter, ticket_IDParameter, ticket_TitleParameter, ticket_DescriptionParameter, ticket_StatusParameter, cREATED_BYParameter, ticket_AdminParameter);
        }
    
        public virtual ObjectResult<Ticket> Ticket_PerformCRUD(string action, Nullable<int> ticket_ID, string ticket_Title, string ticket_Description, string ticket_Status, string cREATED_BY, Nullable<int> ticket_Admin, MergeOption mergeOption)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var ticket_IDParameter = ticket_ID.HasValue ?
                new ObjectParameter("Ticket_ID", ticket_ID) :
                new ObjectParameter("Ticket_ID", typeof(int));
    
            var ticket_TitleParameter = ticket_Title != null ?
                new ObjectParameter("Ticket_Title", ticket_Title) :
                new ObjectParameter("Ticket_Title", typeof(string));
    
            var ticket_DescriptionParameter = ticket_Description != null ?
                new ObjectParameter("Ticket_Description", ticket_Description) :
                new ObjectParameter("Ticket_Description", typeof(string));
    
            var ticket_StatusParameter = ticket_Status != null ?
                new ObjectParameter("Ticket_Status", ticket_Status) :
                new ObjectParameter("Ticket_Status", typeof(string));
    
            var cREATED_BYParameter = cREATED_BY != null ?
                new ObjectParameter("CREATED_BY", cREATED_BY) :
                new ObjectParameter("CREATED_BY", typeof(string));
    
            var ticket_AdminParameter = ticket_Admin.HasValue ?
                new ObjectParameter("Ticket_Admin", ticket_Admin) :
                new ObjectParameter("Ticket_Admin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ticket>("Ticket_PerformCRUD", mergeOption, actionParameter, ticket_IDParameter, ticket_TitleParameter, ticket_DescriptionParameter, ticket_StatusParameter, cREATED_BYParameter, ticket_AdminParameter);
        }
    
        public virtual ObjectResult<UserTicket_CRUD_Result> UserTicket_CRUD(string action, Nullable<int> ticket_ID, string ticket_Title, string ticket_Description, string ticket_Status, string cREATED_BY, Nullable<int> ticket_Admin, string name)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var ticket_IDParameter = ticket_ID.HasValue ?
                new ObjectParameter("Ticket_ID", ticket_ID) :
                new ObjectParameter("Ticket_ID", typeof(int));
    
            var ticket_TitleParameter = ticket_Title != null ?
                new ObjectParameter("Ticket_Title", ticket_Title) :
                new ObjectParameter("Ticket_Title", typeof(string));
    
            var ticket_DescriptionParameter = ticket_Description != null ?
                new ObjectParameter("Ticket_Description", ticket_Description) :
                new ObjectParameter("Ticket_Description", typeof(string));
    
            var ticket_StatusParameter = ticket_Status != null ?
                new ObjectParameter("Ticket_Status", ticket_Status) :
                new ObjectParameter("Ticket_Status", typeof(string));
    
            var cREATED_BYParameter = cREATED_BY != null ?
                new ObjectParameter("CREATED_BY", cREATED_BY) :
                new ObjectParameter("CREATED_BY", typeof(string));
    
            var ticket_AdminParameter = ticket_Admin.HasValue ?
                new ObjectParameter("Ticket_Admin", ticket_Admin) :
                new ObjectParameter("Ticket_Admin", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserTicket_CRUD_Result>("UserTicket_CRUD", actionParameter, ticket_IDParameter, ticket_TitleParameter, ticket_DescriptionParameter, ticket_StatusParameter, cREATED_BYParameter, ticket_AdminParameter, nameParameter);
        }
    
        public virtual ObjectResult<Ticket> UserTicket_PerformCRUD(string action, Nullable<int> ticket_ID, string ticket_Title, string ticket_Description, string ticket_Status, string cREATED_BY, Nullable<int> ticket_Admin, string name)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var ticket_IDParameter = ticket_ID.HasValue ?
                new ObjectParameter("Ticket_ID", ticket_ID) :
                new ObjectParameter("Ticket_ID", typeof(int));
    
            var ticket_TitleParameter = ticket_Title != null ?
                new ObjectParameter("Ticket_Title", ticket_Title) :
                new ObjectParameter("Ticket_Title", typeof(string));
    
            var ticket_DescriptionParameter = ticket_Description != null ?
                new ObjectParameter("Ticket_Description", ticket_Description) :
                new ObjectParameter("Ticket_Description", typeof(string));
    
            var ticket_StatusParameter = ticket_Status != null ?
                new ObjectParameter("Ticket_Status", ticket_Status) :
                new ObjectParameter("Ticket_Status", typeof(string));
    
            var cREATED_BYParameter = cREATED_BY != null ?
                new ObjectParameter("CREATED_BY", cREATED_BY) :
                new ObjectParameter("CREATED_BY", typeof(string));
    
            var ticket_AdminParameter = ticket_Admin.HasValue ?
                new ObjectParameter("Ticket_Admin", ticket_Admin) :
                new ObjectParameter("Ticket_Admin", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ticket>("UserTicket_PerformCRUD", actionParameter, ticket_IDParameter, ticket_TitleParameter, ticket_DescriptionParameter, ticket_StatusParameter, cREATED_BYParameter, ticket_AdminParameter, nameParameter);
        }
    
        public virtual ObjectResult<Ticket> UserTicket_PerformCRUD(string action, Nullable<int> ticket_ID, string ticket_Title, string ticket_Description, string ticket_Status, string cREATED_BY, Nullable<int> ticket_Admin, string name, MergeOption mergeOption)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var ticket_IDParameter = ticket_ID.HasValue ?
                new ObjectParameter("Ticket_ID", ticket_ID) :
                new ObjectParameter("Ticket_ID", typeof(int));
    
            var ticket_TitleParameter = ticket_Title != null ?
                new ObjectParameter("Ticket_Title", ticket_Title) :
                new ObjectParameter("Ticket_Title", typeof(string));
    
            var ticket_DescriptionParameter = ticket_Description != null ?
                new ObjectParameter("Ticket_Description", ticket_Description) :
                new ObjectParameter("Ticket_Description", typeof(string));
    
            var ticket_StatusParameter = ticket_Status != null ?
                new ObjectParameter("Ticket_Status", ticket_Status) :
                new ObjectParameter("Ticket_Status", typeof(string));
    
            var cREATED_BYParameter = cREATED_BY != null ?
                new ObjectParameter("CREATED_BY", cREATED_BY) :
                new ObjectParameter("CREATED_BY", typeof(string));
    
            var ticket_AdminParameter = ticket_Admin.HasValue ?
                new ObjectParameter("Ticket_Admin", ticket_Admin) :
                new ObjectParameter("Ticket_Admin", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ticket>("UserTicket_PerformCRUD", mergeOption, actionParameter, ticket_IDParameter, ticket_TitleParameter, ticket_DescriptionParameter, ticket_StatusParameter, cREATED_BYParameter, ticket_AdminParameter, nameParameter);
        }
    }
}
