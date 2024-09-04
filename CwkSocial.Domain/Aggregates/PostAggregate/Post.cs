using System.Collections;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Domain.Aggregates.PostAggregate;

public class Post
{
    private readonly List<PostComment> _comments = new List<PostComment>();
    private readonly List<PostInteraction> _interactions = new List<PostInteraction>();
    private Post()
    {
    }
    public Guid PostId { get; private set; }
    public Guid UserProfileId { get; private set; }
    public UserProfile UserProfile { get; private set; }
    public string TextContent { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime LastModified { get; private set; }
    public IEnumerable<PostComment> Comments { get {return _comments; } }
    public IEnumerable<PostInteraction> Interactions { get {return _interactions; } }

    //Factories
    public static Post CreatePost(Guid userProfileId, string textContent)
    {
        return new Post
        {   
            UserProfileId = userProfileId,
            TextContent = textContent,
            CreatedDate = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };
    }
    
    //Public methods
    public void UpdatePostText(string textContent)
    {
        TextContent = textContent;
        LastModified = DateTime.UtcNow;
    }

    public void AddPostComment(PostComment comment)
    {
        _comments.Add(comment);
    }
    
    public void RemoveComment(PostComment comment)
    {
        _comments.Remove(comment);
    }
    public void AddPostInteraction(PostInteraction interaction)
    {
        _interactions.Add(interaction);
    }
    
    public void RemovePostInteraction(PostInteraction interaction)
    {
        _interactions.Remove(interaction);
    }
    
}