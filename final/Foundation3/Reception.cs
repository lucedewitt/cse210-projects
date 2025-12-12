class Reception : CurrentEvent
{
    private string _RSVPemail;
    public Reception(string title, string description, string date, string time, Address address, string email) :base(title, description, date, time, address)
    {
        _RSVPemail = email;
    }
    public override string Return()
    {
        return "{_RSVPemail}\nPlease RSVP at the listed email.\nHope to see you there!";
    }
}