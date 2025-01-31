﻿using System.Threading.Tasks;

namespace NET5SignalR.Models
{
    public interface IHubClient
    {
        Task PriceChangedEvent();
        Task ChangeNotice( Notice notice);

        Task AddStock(Stock stock);
    }
}
