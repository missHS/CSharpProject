using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTrainingProject
{
    static class SQL
    {
        //StartPage
        public static string GetScheduledClassFullOverview()
        {
            return "SELECT className AS 'Class', classDate AS 'Date', classTime AS 'Time', instructorName AS 'Instructor', roomName AS 'Room', scheduledClassID AS 'Class ID' FROM ScheduledClass ORDER BY classDate";

        }

        public static string GetScheduledClassFilteredOverview(string date)
        {
            return $"SELECT className AS 'Class', classDate AS 'Date', classTime AS 'Time', instructorName AS 'Instructor', roomName AS 'Room', scheduledClassID AS 'Class ID' FROM ScheduledClass WHERE classDate = '{date}' ORDER BY classDate";
        }
        //BookMemberOnClass

        public static string GetAllMembers()
        {
            return "SELECT memberNumber AS 'Number', memberName AS 'Name' FROM Member";
        }

        public static string InsertIntoBookingClass(int memberNumber, int scheduledClassID)
        {
            return $"INSERT INTO BookingClass VALUES({memberNumber}, {scheduledClassID})";
        }


        //Administrate Class

        public static string GetAllClassesFullOverview()
        {
            return "SELECT className AS 'Class Name', release AS 'Release' FROM Class";
        }

        public static string InsertIntoClass(string className, string release)
        {
            return $"INSERT INTO Class VALUES('{className}','{release}')";
        }

        public static string DeleteClass(string className)
        {
            return $"DELETE Class FROM Class WHERE ClassName = '{className}'";
        }

        public static string UpdateClass(string selectedClass, string newRelease)
        {
            return $"Update Class set release = '{newRelease}' Where className = '{selectedClass}'";
        }

        //UnbookMemberOnClass
        public static string GetMembersBookedOnClass(int scheduledClassIDSelected)
        {
            return $"SELECT p.memberNumber AS 'Member number', s.memberName AS 'Member name' FROM BookingClass p JOIN Member s ON p.memberNumber = s.memberNumber WHERE scheduledClassID = {scheduledClassIDSelected}";

        }

        public static string GetScheduledClassByID(int scheduledClassIDSelected)
        {
            return $"SELECT scheduledClassID AS 'Class ID', className AS 'Class Name', classDate AS 'Date', classTime AS 'Time', roomName AS 'Room', instructorName AS 'Instructor' FROM ScheduledClass WHERE scheduledClassID = '{scheduledClassIDSelected}'";
        }

        public static string DeleteMemberFromBookingClass(string memberNumberSelected)
        {
            return $"DELETE BookingClass FROM BookingClass WHERE memberNumber = '{memberNumberSelected}'";
        }

    
        //ScheduleClass
        public static string GetAllClassesClassNameOnly()
        {
            return "SELECT className AS 'Class Name' FROM class";

        }

        public static string GetHighestClassID()
        {
            return "SELECT MAX(scheduledClassId) FROM ScheduledClass";
        }

        public static string InsertIntoScheduledClass(int classID, string className, string classDate, string classTime, string classRoom, string classInstructor)
        {
            return $"INSERT INTO ScheduledClass VALUES({classID}, '{className}', '{classDate}', '{classTime}', '{classRoom}', '{classInstructor}')";
        }

        //EditScheduledClass
        public static string UpdateScheduledClass(int scheduledClassID, string classDate, string classTime, string classRoom, string classInstructor)
        {
            return $"UPDATE ScheduledClass SET classDate = '{classDate}', classTime = '{classTime}:00', roomName ='{classRoom}', instructorName = '{classInstructor}' WHERE scheduledClassID = {scheduledClassID}";

        }
        public static string DeleteScheduledClass(int scheduledClassID)
        {
            return $"DELETE ScheduledClass WHERE scheduledClassID = {scheduledClassID}";
        }

        public static string FillRoomName(int scheduledClassID)
        {
            return $"SELECT roomName FROM ScheduledClass WHERE scheduledClassID = {scheduledClassID}";
        }

        public static string FillInstructorName(int scheduledClassID)
        {
            return $"SELECT instructorName FROM ScheduledClass WHERE scheduledClassID = {scheduledClassID}";
        }

        public static string FillClassTime(int scheduledClassID)
        {
            return $"SELECT classTime FROM ScheduledClass WHERE scheduledClassID = {scheduledClassID}";
        }

        public static string FillClassDate(int scheduledClassID)
            {
            return $"SELECT classDate FROM ScheduledClass WHERE scheduledClassID = {scheduledClassID}";
        }

        public static string CastClassTime(int scheduledClassID) //osäker om denna behöver ändvändas
        {
            return $"SELECT cast(classTime as varchar(5)) FROM ScheduledClass WHERE scheduledClassID = {scheduledClassID}";
        }
    }
}
