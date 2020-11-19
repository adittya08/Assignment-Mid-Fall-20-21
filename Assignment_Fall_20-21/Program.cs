using System;

namespace Assignment_Fall_20_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Department CSE = new Department("CSE");
            Course OOP2 = new Course("OOP2", "CS104", 3);
            Course OOP1 = new Course("OOP1", "CS103", 3);
            Course C = new Course("Basic of C", "CS101", 3);

            Department EEE = new Department("EEE");
            Course DC = new Course("Electrical circuits 1", "EEE101", 3);
            Course AC = new Course("Electrical circuits 2", "EEE102", 3);
            Course Device = new Course("Electronic devices ", "EEE103", 3);
            Course DSP = new Course("Digital signal processing", "EEE110", 3);


            CSE.addCourse(OOP1);
            CSE.addCourse(OOP2);
            CSE.addCourse(C);
            EEE.addCourse(DC);
            EEE.addCourse(AC);
            EEE.addCourse(Device);
            EEE.addCourse(DSP);


            Section A = new Section("A");
            Section B = new Section("B");
            OOP2.addSection(A);
            OOP2.addSection(B);
            C.addSection(A);
            C.addSection(B);
            OOP1.addSection(A);
            OOP1.addSection(B);
            DC.addSection(A);
            DC.addSection(B);
            AC.addSection(A);
            AC.addSection(B);
            Device.addSection(A);
            Device.addSection(B);
            DSP.addSection(A);


            Faculty tanvirAhmed = new Faculty("Tanvir Ahmed", "1987-456-451", 18);
            tanvirAhmed.addSection(A);
            tanvirAhmed.addSection(B);
            A.addTeacher(tanvirAhmed);
            B.addTeacher(tanvirAhmed);
            OOP1.showSectionAndFaculty();
            tanvirAhmed.showSectionDetails();

            Faculty sadiaYasmin = new Faculty("Sadia Yasmin", "1408-1542-2", 21);
            A.addTeacher(sadiaYasmin);
            B.addTeacher(sadiaYasmin);
            DC.showSectionAndFaculty();
            sadiaYasmin.showSectionDetails();
        }
    }
}
