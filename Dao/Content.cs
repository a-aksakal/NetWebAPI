using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetWebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NetWebAPI.Dao
{
    public class Content
    {

        InsaatContext context = new InsaatContext();

        public async Task<string> GetCityList()
        {
            var cities = await context.Cities.ToListAsync();
            var resultJson = JsonConvert.SerializeObject(
            new[] {    
                new{
                        Result = "İşlem Başarılı!",
                        CityTable = cities
                    }
            });
            return resultJson;
        }

        public async Task<string> PostCity([FromBody]City req)
        {
            var city = new City
            {
                CityName = req.CityName,
            };

            context.Cities.Add(city);

            await context.SaveChangesAsync();
            var resultJson = JsonConvert.SerializeObject(
            new[] {
                new{
                        Result = "İşlem Başarılı!",
                        
                    }
            });
            return resultJson;
        }

        public async Task<string> PutCity([FromBody] City req)
        {
            var city = context.Cities.FirstOrDefault(c => c.CityID == req.CityID);
            city.CityName = req.CityName;

            city.UpdateDate = DateTime.Now;

            await context.SaveChangesAsync();

            var resultJson = JsonConvert.SerializeObject(
            new[] {
                new{
                        Result = "İşlem Başarılı!",

                    }
            });
            return resultJson;
        }

        public async Task<string> DeleteCity([FromBody] City req)
        {
            var city = context.Cities.FirstOrDefault(c => c.CityID == req.CityID);
            context.Cities.Remove(city);

            await context.SaveChangesAsync();

            var resultJson = JsonConvert.SerializeObject(
            new[] {
                new{
                        Result = "İşlem Başarılı!",

                    }
            });
            return resultJson;
        }

        public async Task<string> GetFlatTypeList()
        {
            var con = new SqlConnection(@"Server=DESKTOP-KL3DULI;Database=Insaat;User ID=sa; Password=1234");

            con.Open();

            var query = "SELECT FlatTypeID,FlatTypeName FROM FlatType";

            var cmd = new SqlCommand(query, con);

            SqlDataReader reader = await cmd.ExecuteReaderAsync();

            var dt = new DataTable();

            dt.Load(reader);

            reader.Close();
            con.Close();

            var listFlatType = dt.AsEnumerable().ToList();

            var resultJson = JsonConvert.SerializeObject(
                new[]
                {
                    new
                    {
                        Result = "İşlem Başarılı!",
                        FlatTypeTable = listFlatType.CopyToDataTable(),
                    }
                });

            return resultJson;
        }
        
    }
}
