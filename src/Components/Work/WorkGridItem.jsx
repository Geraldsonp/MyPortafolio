import React from "react";

export default function WorkGridItem({ projectName, codeLink, ProjectImage }) {
  return (
    <div
      style={{ backgroundImage: `url(${ProjectImage})` }}
      className='shadow-lg shadow-[#040c16] group container rounded-md 
          flex justify-center items-center mx-auto content-div'>
      {/* Hover effect*/}
      <div className='opacity-0 group-hover:opacity-100 opacitytrs '>
        <span className='text-2xl font-bold text-white tracking-wider'>{projectName}</span>
        <div className='pt-8 text-center '>
          <a href={codeLink} target='_blank'>
            <button className='text-center rounded-lg px-4 py-3 m-2 bg-white text-gray-700 font-bold text-lg'>
              Demo
            </button>
          </a>
          <a href={codeLink} target='_blank'>
            <button className='text-center rounded-lg px-4 py-3 m-2 bg-white text-gray-700 font-bold text-lg'>
              Code
            </button>
          </a>
        </div>
      </div>
    </div>
  );
}
