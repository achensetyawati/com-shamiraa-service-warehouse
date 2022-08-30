using Com.Shamiraa.Service.Warehouse.Lib.Utilities;
using Com.Shamiraa.Service.Warehouse.Lib.ViewModels.NewIntegrationViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Shamiraa.Service.Warehouse.Lib.ViewModels.TransferViewModels
{
    public class TransferOutDocItemViewModel : BaseViewModel
    {
        public string articleRealizationOrder { get; set; }

        public ItemViewModel item { get; set; }

        public double quantity { get; set; }

        public string remark { get; set; }
    }
}
