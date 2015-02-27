namespace RottenTomatoesApi.Models

type Rating = {
    CriticsRating: string
    CriticsScore: int
    AudienceRating: string
    AudienceScore: int
}

type Movie = {
        Name: string
        Year: int
        Poster: string
        MpaaRating: string
        Runtime: int
        CriticsConsensus: string
        ReleaseDate: string
        Ratings: Rating
    }