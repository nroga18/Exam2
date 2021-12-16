using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    class Task7
    {
        /*
         * CREATE TABLE Pupil (
    PupilID int NOT NULL,
    Name varchar(10) NOT NULL,
    LastName varchar(10),
    Gender varchar(10),
    Class varchar(10),
    PRIMARY KEY (PupilID)
);

CREATE TABLE Teacher (
    TeacherID int NOT NULL,
    Name varchar(10) NOT NULL,
    LastName varchar(10),
    Gender varchar(10),
    Class varchar(10),
    PRIMARY KEY (TeacherID)
);

CREATE TABLE Enrollments (
    EnrollmentID int NOT NULL,
    TeacherID int NOT NULL,
    PupilID int NOT NULL,
    PRIMARY KEY (EnrollmentID),
    FOREIGN KEY (PupilID) REFERENCES Pupil(PupilID)
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID)
);

SELECT Teacher.Name, Teacher.LastName
FROM Enrollments
INNER JOIN Pupil ON Pupil.PupilID=Enrollments.PupilID
INNER JOIN Teacher ON Teacher.TeacherID = Enrollments.TeacherID
WHERE Pupil.Name == "GIORGI";
         */
    }
}
