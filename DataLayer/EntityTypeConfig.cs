using System.Data.Entity.ModelConfiguration;
using InvestingModels;

namespace DataLayer
{

    public class FundConfig : EntityTypeConfiguration<Fund>
    {
        public FundConfig()
        {
            // Relationships.
            //skill has relation with applicant.
            //applicant has many skills (one applicant has many skills )
            //forign key on skill is ApplicantID

            Trade _t = new Trade();

            this.HasRequired(t => t.Trades)
                .WithMany()
                .HasForeignKey(d => d.Id);
        }
    }

    /*
    public class SkillConfig : EntityTypeConfiguration<Skill>
    {
        public SkillConfig()
        {
            // Relationships.
            //skill has relation with applicant.
            //applicant has many skills (one applicant has many skills )
            //forign key on skill is ApplicantID
            this.HasRequired(t => t.Applicant)
                .WithMany(g => g.Skills)
                .HasForeignKey(d => d.ApplicantID);
        }
    }
    */
}

