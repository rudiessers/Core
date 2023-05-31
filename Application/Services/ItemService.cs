using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;
using Infrastructure.Interfaces;

namespace Application.Services;

public class ItemService: IItemService
{
    private readonly IItemRepository _itemRepository;

    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public async Task<Item> GetItem(int id)
    {
        var item = await _itemRepository.GetItemFromDb(id);

        return item;
    }
    
    public async Task<IEnumerable<Item>> GetItems()
    {
        var items = await _itemRepository.GetItemsFromDb();

        return items;
    }

}

