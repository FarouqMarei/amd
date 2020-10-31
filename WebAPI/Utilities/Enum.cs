using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Utilities
{
    public class Enum
    {
        public enum UserType
        {
            Customer = 1,
            Admin = 2
        }

        public enum StatusType
        {
            Failed = 0,
            Success = 1
        }

        public enum CarStatus
        {
            [DisplayName("Bought New")]
            BoughtNew = 1,
            [DisplayName("Awaiting Load")]
            AwaitingLoad = 2,
            [DisplayName("Loaded")]
            Loaded = 3
        }

        public enum DisplayStatus
        {
            D1 = 1,
            D2 = 2,
            D3 = 3
        }

        public enum PaperStatus
        {
            Ready = 1,
            NotReady = 2
        }

        public enum CarType
        {
            Car = 1,
            Van = 2
        }
    }
}
