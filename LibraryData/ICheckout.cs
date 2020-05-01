using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<Checkout> GetAll();
        Checkout GetbyId(int CheckoutId);
        void Add(Checkout newCheckout);
        void CheckoutItem(int id, int libraryCardId);
        void CheckInItem(int id, int libraryCardId);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHold(int id);
        void PlaceHold(int assetId, int libraryCardId);

        Checkout GetLatestCheckout(int assetId);
        string GetCurrentHoldPatronName(int id);
        string GetCurrentHoldPlaced(int id);

        void MarkLost(int id);
        void MarkFound(int id);
    }
}
