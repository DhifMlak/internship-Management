namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Internship : DbContext
    {
        public Internship()
            : base("name=Internship")
        {
        }

        public virtual DbSet<api_audit_trail> api_audit_trail { get; set; }
        public virtual DbSet<api_auditable_entity> api_auditable_entity { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<_class> classes { get; set; }
        public virtual DbSet<convention> conventions { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<document> documents { get; set; }
        public virtual DbSet<enterprise> enterprises { get; set; }
        public virtual DbSet<final_project_assignment> final_project_assignment { get; set; }
        public virtual DbSet<grade> grades { get; set; }
        public virtual DbSet<notification> notifications { get; set; }
        public virtual DbSet<occupation> occupations { get; set; }
        public virtual DbSet<option> options { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<sheet> sheets { get; set; }
        public virtual DbSet<university> universities { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<validation_group> validation_group { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<api_audit_trail>()
                .Property(e => e.action_type)
                .IsUnicode(false);

            modelBuilder.Entity<api_audit_trail>()
                .Property(e => e.ui_designation)
                .IsUnicode(false);

            modelBuilder.Entity<api_audit_trail>()
                .Property(e => e.ui_designation_eng)
                .IsUnicode(false);

            modelBuilder.Entity<api_audit_trail>()
                .Property(e => e.id_obj)
                .IsUnicode(false);

            modelBuilder.Entity<api_audit_trail>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<api_audit_trail>()
                .Property(e => e.user_login)
                .IsUnicode(false);

            modelBuilder.Entity<api_audit_trail>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<api_auditable_entity>()
                .Property(e => e.ui_designation)
                .IsUnicode(false);

            modelBuilder.Entity<api_auditable_entity>()
                .Property(e => e.ui_designation_eng)
                .IsUnicode(false);

            modelBuilder.Entity<api_auditable_entity>()
                .Property(e => e.entity_name)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.label)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.sheets)
                .WithOptional(e => e.category)
                .HasForeignKey(e => e.cat_id);

            modelBuilder.Entity<category>()
                .HasMany(e => e.users)
                .WithMany(e => e.categories1)
                .Map(m => m.ToTable("user_cats").MapLeftKey("cat_id").MapRightKey("userid"));

            modelBuilder.Entity<_class>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .Property(e => e.year)
                .IsUnicode(false);

            modelBuilder.Entity<_class>()
                .HasMany(e => e.users)
                .WithMany(e => e.classes)
                .Map(m => m.ToTable("class_students").MapRightKey("students_id"));

            modelBuilder.Entity<convention>()
                .HasMany(e => e.final_project_assignment)
                .WithRequired(e => e.convention)
                .HasForeignKey(e => e.convention_name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<department>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<department>()
                .HasMany(e => e.options)
                .WithOptional(e => e.department)
                .HasForeignKey(e => e.department_id);

            modelBuilder.Entity<document>()
                .Property(e => e.format_fichier_alf)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.id_fichier_alf)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.nom_fichier_alf)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .Property(e => e.path_fichier_alf)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.domain)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.email_supervisor)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .Property(e => e.web_site)
                .IsUnicode(false);

            modelBuilder.Entity<enterprise>()
                .HasMany(e => e.sheets)
                .WithOptional(e => e.enterprise)
                .HasForeignKey(e => e.enterprise_id);

            modelBuilder.Entity<final_project_assignment>()
                .HasMany(e => e.documents)
                .WithOptional(e => e.final_project_assignment)
                .HasForeignKey(e => e.final_project_assignment_id);

            modelBuilder.Entity<grade>()
                .Property(e => e.level)
                .IsUnicode(false);

            modelBuilder.Entity<grade>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<notification>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<occupation>()
                .Property(e => e.label)
                .IsUnicode(false);

            modelBuilder.Entity<option>()
                .Property(e => e.label)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.users)
                .WithMany(e => e.roles)
                .Map(m => m.ToTable("user_role").MapLeftKey("roleid").MapRightKey("userid"));

            modelBuilder.Entity<sheet>()
    .Property(e => e.etat)
    .IsUnicode(false);

            modelBuilder.Entity<sheet>()
    .Property(e => e.note_encadrant).IsOptional();

            modelBuilder.Entity<sheet>()
    .Property(e => e.note_rapporteur).IsOptional();

            modelBuilder.Entity<sheet>()
    .Property(e => e.note)
    .IsUnicode(false);
            modelBuilder.Entity<sheet>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sheet>()
                .Property(e => e.problematique)
                .IsUnicode(false);

            modelBuilder.Entity<sheet>()
                .Property(e => e.project_title)
                .IsUnicode(false);

            modelBuilder.Entity<sheet>()
                .Property(e => e.student_name)
                .IsUnicode(false);

            modelBuilder.Entity<sheet>()
                .HasMany(e => e.final_project_assignment)
                .WithRequired(e => e.sheet)
                .HasForeignKey(e => e.sheet_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sheet>()
                .HasMany(e => e.grades)
                .WithRequired(e => e.sheet)
                .HasForeignKey(e => e.sheet_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<university>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.address1)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.address2)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.registration_number)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .Property(e => e.web_site)
                .IsUnicode(false);

            modelBuilder.Entity<university>()
                .HasMany(e => e.categories)
                .WithRequired(e => e.university)
                .HasForeignKey(e => e.uni_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<university>()
                .HasMany(e => e.classes)
                .WithOptional(e => e.university)
                .HasForeignKey(e => e.university_id);

            modelBuilder.Entity<university>()
                .HasMany(e => e.conventions)
                .WithOptional(e => e.university)
                .HasForeignKey(e => e.university_id);

            modelBuilder.Entity<university>()
                .HasMany(e => e.departments)
                .WithOptional(e => e.university)
                .HasForeignKey(e => e.university_id);

            modelBuilder.Entity<university>()
                .HasMany(e => e.users)
                .WithOptional(e => e.university)
                .HasForeignKey(e => e.univerity_id);

            modelBuilder.Entity<user>()
                .Property(e => e.descriminator)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.lang_key)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.reset_key)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.token)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.categories)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.maker_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.departments)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.chief_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.enterprises)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.representative_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.final_project_assignment)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.student_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.grades)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.maker_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.notifications)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.owner_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.universities)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.representative_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.validation_group)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.president_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.validation_group1)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.reporter_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.validation_group2)
                .WithOptional(e => e.user2)
                .HasForeignKey(e => e.internship_director_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.validation_group3)
                .WithOptional(e => e.user3)
                .HasForeignKey(e => e.pre_validator_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.validation_group4)
                .WithOptional(e => e.user4)
                .HasForeignKey(e => e.supervisor_id);


            modelBuilder.Entity<user>()
                .HasOptional(e => e.sheet)
                .WithRequired(e => e.user);




            modelBuilder.Entity<user>()
                .HasMany(e => e.occupations)
                .WithMany(e => e.users)
                .Map(m => m.ToTable("user_occupation").MapLeftKey("userid").MapRightKey("occupationid"));

            modelBuilder.Entity<validation_group>()
                .HasMany(e => e.final_project_assignment)
                .WithOptional(e => e.validation_group)
                .HasForeignKey(e => e.validation_group_id);
        }
    }
}
