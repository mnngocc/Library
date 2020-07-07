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
        void CheckInItem(int id);
        bool CheckLibraryCardId(int id);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHold(int id);
        string GetCurrentHoldPatronPhone(int id);
        void PlaceHold(int assetId, int libraryCardId);
        void CheckoutToEarliestHold(int id);
        Checkout GetLatestCheckout(int assetId);
        string GetCurrentHoldPatronName(int id);
        string GetCurrentHoldPatron(int id);
        string GetCurrentPatron(int id);
        string GetCurrentHoldPlaced(int id);
        int NumCheckout();
        string TopAssetName();
        string TopAssetImg();
       // List<Object> TopPatron();
        Patron TopPatron();
        LibraryBranch TopBranch();
        bool CheckHoldExist(int assetId, int libCard);
        int NumBranch();
        int TopAsset();
        void MarkLost(int id);
        void MarkFound(int id);
        bool IsCheckedOut(int id);
        IEnumerable<CheckoutHistory> getAll(int year);
    }
}
