using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearningPortal.DAL.Configurations
{
    public class UserHobbieConfiguration //: IEntityTypeConfiguration<UserHobbie>
    {

        //public void Configure(EntityTypeBuilder<UserHobbie> modelBuilder)
        //{
        //    //modelBuilder
        //    //    .HasKey(t => (new { t.ApplicationUserId, t.HobbieId }));

        //    //modelBuilder
        //    //    .HasOne(pt => pt.ApplicationUser)
        //    //    .WithMany(p => p.UserHobbies )
        //    //    .HasForeignKey(pt => pt.ApplicationUserId);

        //    //modelBuilder
        //    //    .HasOne(pt => pt.Hobbie)
        //    //    .WithMany(t => t.UserHobbies)
        //    //    .HasForeignKey(pt => pt.HobbieId);
        //}
    }
}
