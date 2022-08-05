import React from "react";

function Contact() {
  return (
    <div name='contact' className='bg-[#0a192f] w-full h-screen flex justify-center p-4'>
      <form
        method='post'
        action='https://getform.io/f/42cd1c97-d1b6-4092-bcd6-596bd3adfec4'
        className='flex flex-col max-w-[600px] w-full'>
        <div className='pb-8'>
          <p className='text-4xl font-bold inline border-b-4 border-[#2ba3e0] text-gray-300'>Contact</p>
          <p className='text-gray-300 py-4'>// Submit the form below or shoot me an email - Geraldson.a.p@gmail.com</p>
        </div>
        <input className='bg-[#ccd6f6] p-2' type='text' placeholder='Name' name='name' />
        <input type='email' placeholder='Email' name='email' className='my-4 p-2 bg-[#ccd6f6]' />
        <textarea name='message' placeholder='Message' className='bg-[#ccd6f6] p-2' cols='30' rows='10'></textarea>
        <button className='text-white border-2 hover:bg-[#2ba3e0] hover:border-black px-4 py-3 my-8 mx-auto flex items-center'>
          Let's Collaborate
        </button>
      </form>
    </div>
  );
}

export default Contact;
