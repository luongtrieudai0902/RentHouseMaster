using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using System.IO;

namespace RentHouseMaster.Services
{
    internal class ContractService
    {
        private List<HopDong> contracts = new List<HopDong>();

        // Thêm hợp đồng vào danh sách
        public void AddContract(HopDong hopDong)
        {
            contracts.Add(hopDong);
        }

        // Chỉnh sửa hợp đồng
        public void EditContract(String contractId, HopDong updatedContract)
        {
            var contract = contracts.Find(c => c.HopDongID.Equals(contractId));
            if (contract != null)
            {
                contract.KhachHangID = updatedContract.KhachHangID;
                contract.TaisanID = updatedContract.TaisanID;
                contract.NgayBatDau = updatedContract.NgayBatDau;
                contract.NgayKetThuc = updatedContract.NgayKetThuc;
                contract.TienThue = updatedContract.TienThue;
                contract.TienCoc = updatedContract.TienCoc;
                contract.DieuKhoan = updatedContract.DieuKhoan;
                contract.StorageFilePath = updatedContract.StorageFilePath;
                contract.AutoRenew = updatedContract.AutoRenew;
            }
        }


        // Xóa hợp đồng
        public void DeleteContract(string contractId)
        {
            contracts.RemoveAll(c => c.HopDongID.Equals(contractId));
        }


        // Gia hạn hợp đồng
        public void AutoRenewContract()
        {
            foreach (var contract in contracts)
            {
                if (contract.AutoRenew && contract.NgayKetThuc != default(DateTime) && contract.NgayKetThuc <= DateTime.Now)
                {
                    contract.NgayKetThuc = contract.NgayKetThuc.AddYears(1);
                }
            }
        }


        // Lưu hợp đồng vào file
        public void SaveContractFile(string path)
        {
            if (File.Exists(path))
            {
                string destination = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Contracts", Path.GetFileName(path));
                string? directoryPath = Path.GetDirectoryName(destination);
                if (directoryPath != null)
                {
                    Directory.CreateDirectory(directoryPath);
                    File.Copy(path, destination, true);
                }
            }
        }

        // Chấm dứt hợp đồng

        public void TerminateContract(string contractId)
        {
            var contract = contracts.Find(c => c.HopDongID.Equals(contractId));
            if (contract != null)
            {
                contract.NgayKetThuc = DateTime.Now;
            }
        }

        // Lấy danh sách hợp đồng
        public List<HopDong> GetContracts()
        {
            return contracts;
        }

        // Kiểm tra hợp đồng sắp hêt hạn
        public List<HopDong> GetExpiringContracts(int daysBeforeExpiration)
        {
            return contracts.FindAll(c => c.NgayKetThuc != default(DateTime) && (c.NgayKetThuc - DateTime.Now).TotalDays <= daysBeforeExpiration); 
        }



    }
}
