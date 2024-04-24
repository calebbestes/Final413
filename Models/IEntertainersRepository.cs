namespace Final.Models;

public class IEntertainersRepository
{ 
    public IQueryable<Agent> Agents { get; }
    public IQueryable<Customer> Customers { get; }
    public IQueryable<Entertainer> Entertainers { get; }
    public IQueryable<Engagement> Engagements { get; }
    public IQueryable<EntertainerMember> EntertainerMembers { get; }
    public IQueryable<EntertainerStyle> EntertainerStyles { get; }
    public IQueryable<Member> Members { get; }
    public IQueryable<MusicalPreference> MusicalPreferences { get; }
    public IQueryable<MusicalStyle> MusicalStyles { get; }
    public IQueryable<ZtblDay> ZtblDays { get; }
    public IQueryable<ZtblMonth> ZtblMonths { get; }
    public IQueryable<ZtblSkipLabel> ZtblSkipLabels { get; }
    public IQueryable<ZtblWeek> ZtblWeeks { get; }
}