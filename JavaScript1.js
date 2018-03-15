function emp(firstname , lastname )
{
    this.firstname = firstname;
    this.lastname = lastname;
    
   
}

emp.prototype.getfullname= function()
{
   
        return this.firstname  + this.lastname;
    
    
}
var otherdetail = function(age, id)
{
    this.age = age;
    this.id = id;
}

