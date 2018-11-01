using System;
using System.ComponentModel.DataAnnotations;

namespace testConsole
{
    public class FileModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] File { get; set; }
    }
}