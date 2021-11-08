using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCities.Data.Models
{
  public class City
  {
    #region Constructor
    public City()
    {

    }
    #endregion

    #region properties
    /// <summary>
    /// The unique id and primary key for this City
    /// </summary>
    [Key]
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// City name (in UTF-8 format)
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// City name (in ASCII format)
    /// </summary>
    public string Name_ASCII { get; set; }

    /// <sumary>
    /// City latitude
    /// </summary>
    [Column(TypeName = "decimal(7,4)")]
    public decimal Lat { get; set; }

    /// <summary>
    /// City longitude
    /// </summary>
    [Column(TypeName = "decimal(7,4)")]
    public decimal Lon { get; set; }
    #endregion

    /// <summary>
    /// Country Id (Foreign key)
    /// </summary>
    [ForeignKey("Country")]
    public int CountryId { get; set; }

    #region Navigation Properties
    /// <summary>
    /// The country related to this city
    /// </summary>
    public virtual Country Country { get; set; }
    #endregion
  }
}