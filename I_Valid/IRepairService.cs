using System;

namespace I_Valid
{
    interface IRepairService
    {
        void SendRepairsRequest(int id, DateTime date);
    }
}
