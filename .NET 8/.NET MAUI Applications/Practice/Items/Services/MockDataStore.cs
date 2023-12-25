using Items.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items.Services;

public class MockDataStore : IDataStore<Item>
{
    private readonly List<Item> _item;

    public MockDataStore()
    {
        _item =
        [
            new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description = "This is the 1st item description." },
            new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description = "This is the 2nd item description." },
            new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description = "This is the 3rd item description." },
            new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description = "This is the 4th item description." },
            new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description = "This is the 5th item description." },
            new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description = "This is the 6th item description." }
        ];
    }

    public async Task<Item> GetItemAsync(string id)
    {
        return await Task.FromResult(_item.FirstOrDefault(s => s.Id == id));
    }

    public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
    {
        return await Task.FromResult(_item);
    }

    public async Task<bool> AddItemAsync(Item item)
    {
        _item.Add(item);
        return await Task.FromResult(true);
    }

    public async Task<bool> UpdateItemAsync(Item item)
    {
        Item? oldItem = _item.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
        _item.Remove(oldItem);
        _item.Add(item);
        return await Task.FromResult(true);
    }

    public async Task<bool> DeleteItemAsync(string id)
    {
        Item? oldItem = _item.Where((Item arg) => arg.Id == id).FirstOrDefault();
        _item.Remove(oldItem);
        return await Task.FromResult(true);
    }
}