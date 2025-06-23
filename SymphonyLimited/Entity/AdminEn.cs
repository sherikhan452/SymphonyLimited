namespace SymphonyLimited.Entity
{
   
     

        public class Admin
        {
            public int AdminId { get; set; }
            public string Username { get; set; }
            public string PasswordHash { get; set; } // Store hashed password
            public string Email { get; set; }
        }

        public class Course
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public string Description { get; set; }
            public bool IsNewCourse { get; set; }

            public virtual ICollection<Topic> Topics { get; set; }
        }


        public class Topic
        {
            public int TopicId { get; set; }
            public string TopicName { get; set; }

            public int CourseId { get; set; }
            public virtual Course Course { get; set; }
        }

        public class EntranceExam
        {
            public int EntranceExamId { get; set; }
            public DateTime ExamDate { get; set; }
            public decimal ExamFee { get; set; }
            public bool IsActive { get; set; }
        }


        public class StudentResult
        {
            public int StudentResultId { get; set; }

            public string RollNumber { get; set; }
            public string StudentName { get; set; }
            public int Marks { get; set; }

            public string ClassAssigned { get; set; }
            public decimal FeesAmount { get; set; }
            public DateTime ResultDate { get; set; }
        }
    
}
