import React from "react";
import WorkImg from "../../Assets/workImg.jpeg";
import WorkGridItem from "./WorkGridItem";
import RemoloLogo from "../../Assets/RemoloLogo.jpg";

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
            projectName='Issues Traker Web API'
            ProjectImage={WorkImg}
            codeLink={"https://github.com/Geraldsonp/IssueTrackingWebApi"}></WorkGridItem>
          <WorkGridItem
            projectName='RemoloPizza Web API'
            codeLink='https://github.com/Geraldsonp/DonRemoloPizza.WebApi'
            demoLink={"https://donremolopizzawebapi-production.up.railway.app/swagger/index.html"}
            ProjectImage={RemoloLogo}></WorkGridItem>
          <WorkGridItem
            projectName='RemoloPizza CMS'
            ProjectImage={"https://gpspersonalbucket.s3.amazonaws.com/Pizzerialogo.jpg"}
            codeLink={"https://github.com/Geraldsonp/pizzacms.git"}
            demoLink={"https://brilliant-tarsier-b9abbe.netlify.app/"}></WorkGridItem>
        </div>
      </div>
    </div>
  );
};

export default Work;
