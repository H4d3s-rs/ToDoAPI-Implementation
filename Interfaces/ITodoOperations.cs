using System;
using ToDoAPI.Models;

namespace ToDoAPI.Interfaces;

public interface ITodoOperations
{
    public Task<List<ItemModel>> ShowTasks();

    public Task<ItemModel> GetTaskById(int id);

    public Task<List<ItemModel>> InsertTask(ItemModel task);

    public Task<List<ItemModel>> UpdateTask(ItemModel task);

    public Task<List<ItemModel>> DeleteTask(int id);
}
