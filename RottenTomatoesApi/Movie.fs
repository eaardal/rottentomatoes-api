namespace RottenTomatoesApi.Models

type Rating = {
    CriticsRating: string
    CriticsScore: int
    AudienceRating: string
    AudienceScore: int
}

 type CastMember(name: string, characters: string[]) = 

    let mutable name = name
    let mutable characters = characters
        
    member x.Name with get() = name and set value = name <- value
    member x.Characters with get() = characters and set(value) = characters <- value
    member x.DisplayText with get () = sprintf "%s as %s" x.Name (String.concat ", " x.Characters)
 

 type AlternateIDs = {
    IMDb: string
 }

type Movie = {
        Title: string
        Year: int
        Poster: string
        MpaaRating: string
        Runtime: int
        CriticsConsensus: string
        ReleaseDate: string
        Ratings: Rating
        Synopsis: string
        AbridgedCast: CastMember[]
        AlternateIDs: AlternateIDs
    }