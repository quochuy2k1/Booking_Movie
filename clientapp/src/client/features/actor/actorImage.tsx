import { useCallback, useEffect, useState } from "react";
import { List, Image } from "semantic-ui-react";
import { ActorImageModel, GetAllActorImage } from "../../../services/actor.service";


const ActorImage: React.FC<{ id: string | undefined }> = ({ id }) => {
    const [actorImages, setActorImages] = useState<ActorImageModel[] | null>(null);

    const GetActorImage = useCallback(async () => {
        if (id !== undefined) {
            const result = await GetAllActorImage(id);
            setActorImages([...result.data]);
        }
    }, [id])
    useEffect(() => {
        GetActorImage();
    }, [GetActorImage])

    return (
        <>
            <List horizontal className="">
                {actorImages && actorImages.map((actorImage, idx) => (
                    <List.Item key={idx}>
                        <Image size="small" src={actorImage.imagePath} />

                    </List.Item>
                ))}


            </List>
        </>
    )
}

export default ActorImage;