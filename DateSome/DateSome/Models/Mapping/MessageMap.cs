using System.Data.Entity.ModelConfiguration;

namespace DateSome.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            this.HasOptional(m => m.ReplyTo).WithMany(m=>m.Replies).WillCascadeOnDelete(false);
        }
    }
}