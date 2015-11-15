﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.DBHandler;
using HealthCareModel.Object_Models;

namespace HealthCareModel.ControlHandler
{   
    public static class ExtendedControl
    {
        private static IAlarmAttendanceHandler alarmAttendanceHandler = new AlarmAttendanceHandler();
        private static IAlarmCountHandler alarmCountHandler = new AlarmCountHandler();
        private static IAssignedTaskHandler assignedTaskHandler = new AssignedTaskHandler();

        #region IAlarmAttendanceHandler implementation
        public static void createAlarmAttendance(string alarmName, string userName)
        {
            alarmAttendanceHandler.createAlarmAttendance(alarmName, userName);
        }

        public static void deleteAlarmAttendance(int alarmId, int userId)
        {
            alarmAttendanceHandler.deleteAlarmAttendance(alarmId, userId);
        }

        public static List<User> getAllarmAttendants(int alarmId)
        {
            return alarmAttendanceHandler.getAllarmAttendants(alarmId);
        }
        #endregion

        #region IAlarmCountHandler implementation
        public static void createAlarmCount(string alarmName)
        {
            alarmCountHandler.createAlarmCount(alarmName);
        }

        public static void deleteAlarmCount(int alarmId)
        {
            alarmCountHandler.deleteAlarmCount(alarmId);
        }

        public static AlarmCount getAlarmCount(int alarmId)
        {
            return alarmCountHandler.getAlarmCount(alarmId);
        }

        public static void incrementAlarmCount(int alarmId)
        {
            alarmCountHandler.incrementAlarmCount(alarmId);
        }
        #endregion

        #region IAssignedTaskHandler implementation
        public static List<User> getTaskUsers(string taskName)
        {
            return assignedTaskHandler.getTaskUsers(taskName);
        }

        public static List<Task> getUserTasks(string username)
        {
            return assignedTaskHandler.getUserTasks(username);
        }

        public static void createAssignedTask(string taskName, string username)
        {
            assignedTaskHandler.createAssignedTask(taskName, username);
        }

        public static void deleteAssignedTask(int taskId, int userId)
        {
            assignedTaskHandler.deleteAssignedTask(taskId, userId);
        }
        #endregion
    }
}
