using ToDoAPI.Interfaces;
using ToDoAPI.Models;
using ToDoAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ToDoAPI.Services;

public class TodoOperationsService : ITodoOperations
{
    
    private readonly ApplicationDbContext _context;

    public TodoOperationsService(ApplicationDbContext context)
    {
        _context = context;

    }

    public async Task<ItemModel> GetTaskById(int id)
    {
        ItemModel item = _context.Items.FirstOrDefault(x => x.IdItem == id);
        return item;

    }

    public async Task<List<ItemModel>> ShowTasks()
    {
        return await _context.Items.ToListAsync();

    }


    public async Task<List<ItemModel>> InsertTask(ItemModel task)
    {
        _context.Items.Add(task);
        await _context.SaveChangesAsync();

        return await _context.Items.ToListAsync();

    }


    public async Task<List<ItemModel>> UpdateTask(ItemModel task)
    {
        _context.Items.Update(task);
        await _context.SaveChangesAsync();

        return await _context.Items.ToListAsync();
       
    }
    

    public async Task<List<ItemModel>> DeleteTask(int id)
    {
        ItemModel item = _context.Items.FirstOrDefault(x => x.IdItem == id);

        _context.Items.Remove(item);
        await _context.SaveChangesAsync();

        return  await _context.Items.ToListAsync();
    }
}