using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302220009.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Marjauza Naswansyah", "1302220009"),
        new Mahasiswa(" Nizar Rasyiid", "1302220037"),
        new Mahasiswa(" Hasan Nurrahman Pane", "1302220031"),
        new Mahasiswa(" Matthew Theodore Lempas" , "1302223116"),
    };
        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}