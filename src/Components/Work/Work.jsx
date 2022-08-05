import React from "react";
import WorkImg from "../../Assets/workImg.jpeg";
import WorkGridItem from "./WorkGridItem";

const Work = () => {
  return (
    <div name='work' className='w-full md:h-screen text-gray-300 bg-[#0a192f]'>
      <div className='ccontainer'>
        <div pb-8>
          <p className='text-4xl font-bold border-b-4 inline border-[#2ba3e0] '>Work</p>
          <p className='py-6'>// Check out some of my recent work</p>
        </div>

        {/* Container */}
        <div className='grid sm:grid-cols-2 md:grid-cols-3 gap-4 '>
          <WorkGridItem
            projectName='Issues Web API'
            codeLink='https://github.com/Geraldsonp/IssueTrackingWebApi'
            ProjectImage={WorkImg}></WorkGridItem>
          <WorkGridItem projectName='Issues React Client' ProjectImage={WorkImg}></WorkGridItem>
          <WorkGridItem projectName='Todo-App Web API' ProjectImage={WorkImg}></WorkGridItem>
          <WorkGridItem projectName='Todo-App Web Client' ProjectImage={WorkImg}></WorkGridItem>
        </div>
      </div>
    </div>
  );
};

export default Work;
