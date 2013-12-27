using System.Data.Entity.ModelConfiguration;

namespace DateSome.Models.Mapping
{
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            this.HasMany(up => up.ReceivedMessages).WithRequired(m => m.Receiver).WillCascadeOnDelete(false);
            this.HasMany(up => up.SentMessages).WithRequired(m => m.Sender).WillCascadeOnDelete(false);
        }
    }
}