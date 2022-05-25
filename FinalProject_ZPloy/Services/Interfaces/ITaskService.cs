using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mPloy_FinalProject_group5.Services.Interfaces
{
    public interface ITaskService
    {
        void CreateTask(Models.Task task, int creatorID);

        IEnumerable<Models.Task> GetAllTasks();

        IEnumerable<Models.Task> GetTasksFilteredByCategory(string category);

        IEnumerable<Models.Task> GetUserTasksCreatedByUserId(int userID);

        Models.Task GetTask(int id);

        void DeleteTask(int id);

        void EditTask(Models.Task task, int creatorID);

        Models.Task UpdateTask(Models.Task task, int creatorID);

    }
}
