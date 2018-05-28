import React from "react";
const Content=(props)=>{
    return (
        <div dangerouslySetInnerHTML ={{ __html: props.content}}/>
    )
};

export default Content;